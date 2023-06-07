import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
import { Container, Row, Col, Card, Button } from 'react-bootstrap';
import '../styles/eventlist.css';


const EventsList = () => {
    const [events, setEvents] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get('http://localhost:5245/api/events');
                setEvents(response.data);
            } catch (error) {
                console.error('Error fetching data from server', error);
            }
        };

        fetchData();
    }, []);

    return (
        <Container fluid>
            <Row className="justify-content-md-center mb-3">
                <Col md="auto">
                    <h1>Events List</h1>
                </Col>
            </Row>
            <Row>
                {events.map(event => (
                    <Col xs={12} md={6} lg={4} key={event.id} className="mb-4">
                    <Link to={`/events/${event.id}`}>
                        <Card>
                            <Card.Img variant="top" src={event.imageUrl} />
                            <Card.Body>
                                <Card.Title>{event.name}</Card.Title>
                                <Card.Text>
                                    <div><b>Date:</b> {new Date(event.date).toLocaleDateString()}</div>
                                    <div><b>Time:</b> {event.time}</div>
                                    <div><b>Category:</b> {event.category}</div>
                                </Card.Text>
                                <Button variant="primary" href={event.ticketLink} target="_blank" rel="noopener noreferrer">
                                    Book Tickets
                                </Button>
                            </Card.Body>
                        </Card>
                    </Link>
                </Col>
                
                ))}
            </Row>
        </Container>
    );
};

export default EventsList;
