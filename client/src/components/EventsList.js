import React, { useState, useEffect } from 'react';
import axios from 'axios';

const EventsList = () => {
    const [events, setEvents] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get('http://localhost:5000/api/events');
                setEvents(response.data);
            } catch (error) {
                console.error('Error fetching data from server', error);
            }
        };

        fetchData();
    }, []); // Passing an empty array as second argument to useEffect makes it run only on initial render

    return (
        <div>
            <h1>Events List</h1>
            {events.map(event => (
                <div key={event.id}>
                    <h2>{event.name}</h2>
                    <p>{event.description}</p>
                </div>
            ))}
        </div>
    );
};

export default EventsList;
