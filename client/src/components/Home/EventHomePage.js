import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Container, Row, Col, Card, Button, Form, Pagination } from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSearch, faMapMarkerAlt, faTags, faTicketAlt } from '@fortawesome/free-solid-svg-icons';
import { Link, useParams } from 'react-router-dom';
import '../../styles/eventHomePage.css';

const EventHomePage = () => {
    const [events, setEvents] = useState([]);
    const [search, setSearch] = useState('');
    const [currentPage, setCurrentPage] = useState(1);
    const [eventsPerPage] = useState(6);
    const [location, setLocation] = useState('');
    const [categories, setCategories] = useState([]);
    const [IsOnline, setIsOnline] = useState(false);
    const [currentEvents, setCurrentEvents] = useState([]);

    const [selectedCategory, setSelectedCategory] = useState('');
    const [allCategories, setAllCategories] = useState([]);
    let { id } = useParams();
    useEffect(() => {
        const fetchEvents = async () => {
            try {
                const response = await axios.get('http://localhost:5245/api/events');
                setEvents(response.data);
                setCurrentEvents(response.data);
            } catch (error) {
                console.error('Error fetching events from server', error);
            }
        };

        const fetchCategories = async () => {
            try {
                const response = await axios.get('http://localhost:5245/api/categories'); // adjust this URL
                setAllCategories(response.data);
            } catch (error) {
                console.error('Error fetching categories from server', error);
            }
        };
    

        const fetchOnlineEvents = async () => {
            try {
                const response = await axios.get('http://localhost:5245/api/events/online');
                setEvents(response.data);
                setCurrentEvents(response.data);
            } catch (error) {
                console.error('Error fetching online events from server', error);
            }
        };
        

        fetchEvents();
        fetchCategories();
        fetchOnlineEvents();
    }, []);

    useEffect(() => {
        const filtered = events.filter(event =>
            event.name.toLowerCase().includes(search.toLowerCase()) &&
            (!location || event.location.toLowerCase().includes(location.toLowerCase())) &&
            (!selectedCategory || (event.category === selectedCategory)) && 
            (IsOnline ? event.isOnline : true)
        );
        setCurrentEvents(filtered);
    }, [search, location, selectedCategory, IsOnline]);
    
    
    

    const handleLocationChange = (e) => {
        setLocation(e.target.value);
        setCurrentPage(1); 
    };

    const handleCategoryChange = (e) => {
        setSelectedCategory(e.target.value); 
        setCurrentPage(1);
    };
    

    const handleIsOnlineChange = (e) => {
        setIsOnline(e.target.checked);
        setCurrentPage(1); 
    };
    

    const indexOfLastEvent = currentPage * eventsPerPage;
    const indexOfFirstEvent = indexOfLastEvent - eventsPerPage;
    const currentDisplayEvents = currentEvents.slice(indexOfFirstEvent, indexOfLastEvent);
    
    const totalPages = Math.ceil(currentEvents.length / eventsPerPage);

    const handleSearchChange = e => {
        setSearch(e.target.value);
        setCurrentPage(1); 
    };

    let items = [];
    for (let number = 1; number <= totalPages; number++) {
        items.push(
            <Pagination.Item key={number} active={number === currentPage} onClick={() => setCurrentPage(number)}>
                {number}
            </Pagination.Item>
        );
    }


    return (
        <Container fluid className="eventHomePage">
            {/* <Row className="justify-content-md-center mb-3">
                <Col md="auto">
                    <h1>Home Page</h1>
                </Col>
            </Row> */}
            <Row>
            <Col xs={12} className="search-box">
                <Card>
                <Card.Body>
                    <Form>
                    <Row>
                        <Col md={3}>
                            <Form.Group controlId="searchEvent">
                                <Form.Label><FontAwesomeIcon icon={faSearch} /> Event</Form.Label>
                                <Form.Control
                                    type="text"
                                    placeholder="Search for event..."
                                    value={search}
                                    onChange={handleSearchChange}
                                />
                            </Form.Group>
                        </Col>

                        <Col md={3}>
                            <Form.Group controlId="location">
                                <Form.Label><FontAwesomeIcon icon={faMapMarkerAlt} /> Location</Form.Label>
                                <Form.Control
                                    type="text"
                                    placeholder="City or postcode"
                                    value={location}
                                    onChange={handleLocationChange}
                                />
                            </Form.Group>
                        </Col>

                        <Col md={3}>
                            <Form.Group controlId="category">
                                <Form.Label><FontAwesomeIcon icon={faTags} /> Category</Form.Label>
                                <Form.Control
                                    as="select"
                                    value={selectedCategory}
                                    onChange={handleCategoryChange}
                                >
                                    <option value="">Select category...</option>
                                    {allCategories.map((categoryItem) => (
                                        <option key={categoryItem.id} value={categoryItem.name}>
                                            {categoryItem.name}
                                        </option>
                                    ))}
                                </Form.Control>

                            </Form.Group>
                        </Col>

                        <Col md={3} className="d-flex align-items-center">
                            <Form.Group controlId="IsOnline" className="mb-0">
                            <Form.Check 
                                    type="checkbox" 
                                    label={<><FontAwesomeIcon icon={faTicketAlt} /> Is Online?</>} 
                                    checked={IsOnline} 
                                    onChange={handleIsOnlineChange} 
                                />
                            </Form.Group>
                        </Col>
                    </Row>
                </Form>
                </Card.Body>
                </Card>
            </Col>
            </Row>

            <Row>
                {currentDisplayEvents.map(event => (
                    <Col xs={12} sm={6} md={4} lg={3} key={event.id} className="mb-4">
                        <Card className="event-card">
                            <Card.Img variant="top" src={event.imageUrl} />
                            <Card.Body>
                                <Card.Title>{event.name}</Card.Title>
                                <Card.Text>
                                    <div><b>Date:</b> {new Date(event.date).toLocaleDateString()}</div>
                                    <div><b>Time:</b> {event.time}</div>
                                    <div><b>Category:</b> {event.category}</div>
                                </Card.Text>
                                <Button variant="primary" as={Link} to={`/events/${event.id}`}>
                                    View Event Details
                                </Button>
                            </Card.Body>
                        </Card>
                    </Col>
                ))}
            </Row>
            <Row>
                <Col xs={12}>
                    <Pagination>{items}</Pagination>
                </Col>
            </Row>
        </Container>
    );
};

export default EventHomePage;
