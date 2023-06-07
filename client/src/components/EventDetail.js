import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams } from 'react-router-dom';
import { Container, Row, Col, Card } from 'react-bootstrap';

const EventDetail = () => {
    const { id } = useParams();
    const [event, setEvent] = useState({});
    const [tickets, setTickets] = useState([]);

    useEffect(() => {
        const fetchEvent = async () => {
            try {
                const response = await axios.get(`http://localhost:5245/api/events/${id}`);
                setEvent(response.data);
            } catch (error) {
                console.error('Error fetching data from server', error);
            }
        };

        const fetchTickets = async () => {
            try {
                const response = await axios.get(`http://localhost:5245/api/tickets?eventId=${id}`);
                setTickets(response.data);
            } catch (error) {
                console.error('Error fetching data from server', error);
            }
        };

        fetchEvent();
        fetchTickets();
    }, [id]);

    return (
        <Container fluid>
            <Row>
                <Col>
                    <h1>{event.name}</h1>
                    <p>{event.description}</p>
                    {/* Add more details as needed */}
                </Col>
            </Row>
            <Row>
                <h2>Tickets</h2>
                {tickets.map(ticket => (
                    <Col key={ticket.id}>
                        <Card>
                            <Card.Body>
                                <Card.Title>Ticket for {ticket.attendeeName}</Card.Title>
                                <Card.Text>
                                    Email: {ticket.attendeeEmail} <br />
                                    Price: {ticket.price} <br />
                                    Purchased on: {new Date(ticket.purchaseDate).toLocaleDateString()}
                                </Card.Text>
                                {/* Add more details as needed */}
                            </Card.Body>
                        </Card>
                    </Col>
                ))}
            </Row>
        </Container>
    );
};

export default EventDetail;
