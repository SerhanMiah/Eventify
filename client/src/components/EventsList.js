// import React, { useState, useEffect } from 'react';
// import axios from 'axios';
// import { Link } from 'react-router-dom';
// import { Container, Row, Col, Card, Button, Pagination, Form, InputGroup } from 'react-bootstrap';
// import '../styles/eventlist.css';

// const EventsList = () => {
//     const [events, setEvents] = useState([]);
//     const [search, setSearch] = useState('');
//     const [currentPage, setCurrentPage] = useState(1);
//     const [eventsPerPage] = useState(6);

//     useEffect(() => {
//         const fetchData = async () => {
//             try {
//                 const response = await axios.get('http://localhost:5245/api/events');
//                 setEvents(response.data);
//             } catch (error) {
//                 console.error('Error fetching data from server', error);
//             }
//         };

//         fetchData();
//     }, []);

//     const indexOfLastEvent = currentPage * eventsPerPage;
//     const indexOfFirstEvent = indexOfLastEvent - eventsPerPage;
//     const currentEvents = events.slice(indexOfFirstEvent, indexOfLastEvent);
//     const totalPages = Math.ceil(events.length / eventsPerPage);

//     const filteredEvents = currentEvents.filter(event => 
//         event.name.toLowerCase().includes(search.toLowerCase())
//     );

//     const handleSearchChange = e => {
//         setSearch(e.target.value);
//     };

//     let items = [];
//     for (let number = 1; number <= totalPages; number++) {
//         items.push(
//             <Pagination.Item key={number} active={number === currentPage} onClick={() => setCurrentPage(number)}>
//                 {number}
//             </Pagination.Item>
//         );
//     }

//     return (
//         <Container fluid>
//             <Row className="justify-content-md-center mb-3">
//                 <Col md="auto">
//                     <h1>Events List</h1>
//                 </Col>
//             </Row>
//             <Row>
//                 <Col>
//                     <InputGroup className="mb-3">
//                         <InputGroup.Text id="basic-addon1">Search</InputGroup.Text>
//                         <Form.Control
//                             placeholder="Event name"
//                             aria-label="Event name"
//                             aria-describedby="basic-addon1"
//                             onChange={handleSearchChange}
//                         />
//                     </InputGroup>
//                 </Col>
//             </Row>
//             <Row>
//                 {filteredEvents.map(event => (
//                     <Col xs={12} md={6} lg={4} key={event.id} className="mb-4">
//                         <Link to={`/events/${event.id}`}>
//                             <Card>
//                                 <Card.Img variant="top" src={event.imageUrl} />
//                                 <Card.Body>
//                                     <Card.Title>{event.name}</Card.Title>
//                                     <Card.Text>
//                                         <div><b>Date:</b> {new Date(event.date).toLocaleDateString()}</div>
//                                         <div><b>Time:</b> {event.time}</div>
//                                         <div><b>Category:</b> {event.category}</div>
//                                     </Card.Text>
//                                     <Button variant="primary" href={event.ticketLink} target="_blank" rel="noopener noreferrer">
//                                         Book Tickets
//                                     </Button>
//                                 </Card.Body>
//                             </Card>
//                         </Link>
//                     </Col>
//                 ))}
//             </Row>
//             <Row>
//                 <Col>
//                     <Pagination>{items}</Pagination>
//                 </Col>
//             </Row>
//         </Container>
//     );
// };

// export default EventsList;
