import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';
import { Container, Row, Col, Card, Button, Badge } from 'react-bootstrap';
import '../styles/eventdetail.css';

const EventDetail = () => {
    const { id } = useParams();
    const [event, setEvent] = useState({});
    const navigate = useNavigate();

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

    const attendEvent = async () => {
        try {
            const response = await axios.post(`http://localhost:5245/api/EventAttendance/${id}`);
            if(response.status === 200) {
                alert("Successfully attended event");
                navigate('/');
            }
        } catch (error) {
            console.error('Error attending the event', error);
        }
    };

    return (
        <Container className="event-detail-container">
            <Row>
                <Col xs={12} md={8}>
                    <h1 className="event-title">{event.name}</h1>
                    <Badge variant="info">{event.category}</Badge>
                    <img className="event-image" src={event.imageUrl} alt={event.name} />
                    <h2>About This Event</h2>
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
                            <Card.Title>Category</Card.Title>
                            <Card.Text>{event.category}</Card.Text>
                            <Button variant="primary" href={event.ticketLink} target="_blank" rel="noopener noreferrer">
                                Book Tickets
                            </Button>
                            <Button variant="success" onClick={attendEvent}>Attend Event</Button>
                        </Card.Body>
                    </Card>
                    <Card className="event-organizer-card">
                        <Card.Body>
                            <Card.Title>About the Organizer</Card.Title>
                            <Card.Text>{event.organizerDescription}</Card.Text>
                            <Button variant="primary" href={event.organizerLink} target="_blank" rel="noopener noreferrer">
                                View Organizer Profile
                            </Button>
                        </Card.Body>
                    </Card>
                </Col>
            </Row>
        </Container>
    );
};

export default EventDetail;
