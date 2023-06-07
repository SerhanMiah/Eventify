import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams } from 'react-router-dom';
import { Container, Row, Col, Card, Button } from 'react-bootstrap';
import '../styles/eventdetail.css';

const EventDetail = () => {
    const { id } = useParams();
    const [event, setEvent] = useState({});

    useEffect(() => {
        const fetchEvent = async () => {
            try {
                const response = await axios.get(`http://localhost:5245/api/events/${id}`);
                setEvent(response.data);
            } catch (error) {
                console.error('Error fetching data from server', error);
            }
        };

        fetchEvent();
    }, [id]);

    return (
        <Container className="event-detail-container">
            <Row>
                <Col xs={12} md={8}>
                    <h1 className="event-title">{event.name}</h1>
                    <img className="event-image" src={event.imageUrl} alt={event.name} />
                    <p className="event-description">{event.description}</p>
                </Col>
                <Col xs={12} md={4}>
                    <Card className="event-info-card">
                        <Card.Body>
                            <Card.Title>Date & Time</Card.Title>
                            <Card.Text>{new Date(event.date).toLocaleDateString()} at {event.time}</Card.Text>
                            <Card.Title>Location</Card.Title>
                            <Card.Text>{event.location}</Card.Text>
                            <Card.Title>Organizer</Card.Title>
                            <Card.Text>{event.organizer}</Card.Text>
                            <Button variant="primary" href={event.ticketLink} target="_blank" rel="noopener noreferrer">
                                Book Tickets
                            </Button>
                        </Card.Body>
                    </Card>
                </Col>
            </Row>
        </Container>
    );
};

export default EventDetail;
