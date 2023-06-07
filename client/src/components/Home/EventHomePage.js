import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Container, Row, Col, Card, Button, Form, Pagination } from 'react-bootstrap';
import { Link } from 'react-router-dom';

const EventHomePage = () => {
    const [events, setEvents] = useState([]);
    const [search, setSearch] = useState('');
    const [currentPage, setCurrentPage] = useState(1);
    const [eventsPerPage] = useState(10); // You can adjust this number

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get(`http://localhost:5245/api/events?page=${currentPage}&search=${search}`);
                setEvents(response.data);
            } catch (error) {
                console.error('Error fetching data from server', error);
            }
        };

        fetchData();
    }, [currentPage, search]);

    const onChangeSearch = e => {
        setSearch(e.target.value);
        setCurrentPage(1); // Reset to first page when search changes
    };

    const totalEvents = events.length;
    const indexOfLastEvent = currentPage * eventsPerPage;
    const indexOfFirstEvent = indexOfLastEvent - eventsPerPage;
    const currentEvents = events.slice(indexOfFirstEvent, indexOfLastEvent);

    // Change page
    const paginate = pageNumber => setCurrentPage(pageNumber);

    // Get page numbers
    const pageNumbers = [];
    for (let i = 1; i <= Math.ceil(totalEvents / eventsPerPage); i++) {
        pageNumbers.push(i);
    }

    return (
        <Container fluid>
            <Row className="justify-content-md-center mb-3">
                <Col md="auto">
                    <h1>Home Page</h1>
                </Col>
            </Row>
            <Row>
                <Col xs={12}>
                    <Form.Control
                        type="text"
                        placeholder="Search for event..."
                        value={search}
                        onChange={onChangeSearch}
                    />
                </Col>
            </Row>
            <Row>
                {currentEvents.map(event => (
                    <Col xs={12} md={6} lg={4} key={event.id} className="mb-4">
                        <Card>
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
                    <Pagination>
                        {pageNumbers.map(number => (
                            <Pagination.Item key={number} active={number === currentPage} onClick={() => paginate(number)}>
                                {number}
                            </Pagination.Item>
                        ))}
                    </Pagination>
                </Col>
            </Row>
        </Container>
    );
};

export default EventHomePage;
