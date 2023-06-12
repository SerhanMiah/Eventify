import axios from 'axios';
import React, { useState } from 'react';
import { useHistory, useNavigate } from 'react-router-dom';
import '../../styles/CreateEventForm.css'
const CreateEventForm = () => {
    const [name, setName] = useState('');
    const [description, setDescription] = useState('');
    const [date, setDate] = useState(new Date());
    const [location, setLocation] = useState('');
    const [isOnline, setIsOnline] = useState(false);
    const [category, setCategory] = useState('');

    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post('http://localhost:5245/api/events/createEvent' , {
                name,
                description,
                date,
                location,
                isOnline,
                category
            }) 
            if(response.status === 201) {
                alert('Event Created Successfully!');
                navigate.push('/'); // or wherever you want to redirect after successful event creation
            } else {
                alert('Error creating event');
            }
        } catch (error) {
            console.error('Error creating event', error);
        }
    };

    return (
        <form onSubmit={handleSubmit} className="container">
    <div className="mb-3 row">
        <label className="col-sm-2 col-form-label">Event Name</label>
        <div className="col-sm-10">
            <input type="text" className="form-control" value={name} onChange={(e) => setName(e.target.value)} required/>
        </div>
    </div>
    <div className="mb-3 row">
        <label className="col-sm-2 col-form-label">Event Description</label>
        <div className="col-sm-10">
            <input type="text" className="form-control" value={description} onChange={(e) => setDescription(e.target.value)} required/>
        </div>
    </div>
    <div className="mb-3 row">
        <label className="col-sm-2 col-form-label">Event Date</label>
        <div className="col-sm-10">
            <input type="date" className="form-control" value={date} onChange={(e) => setDate(e.target.value)} required/>
        </div>
    </div>
    <div className="mb-3 row">
        <label className="col-sm-2 col-form-label">Event Location</label>
        <div className="col-sm-10">
            <input type="text" className="form-control" value={location} onChange={(e) => setLocation(e.target.value)}/>
        </div>
    </div>
    <div className="mb-3 row">
        <label className="col-sm-2">Is the event online?</label>
        <div className="col-sm-10">
            <input className="form-check-input" type="checkbox" checked={isOnline} onChange={(e) => setIsOnline(e.target.checked)} />
        </div>
    </div>
    <div className="mb-3 row">
        <label className="col-sm-2 col-form-label">Category</label>
        <div className="col-sm-10">
            <select className="form-select" value={category} onChange={(e) => setCategory(e.target.value)}>
                {/* categories options */}
            </select>
        </div>
    </div>
    <div className="mb-3 row">
        <div className="col-sm-10 offset-sm-2">
            <button type="submit" className="btn btn-primary">Create Event</button>
        </div>
    </div>
</form>
    );
};

export default CreateEventForm;
