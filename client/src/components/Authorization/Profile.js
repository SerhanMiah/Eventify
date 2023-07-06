import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { getToken } from '../helpers/auth';
import { useNavigate } from 'react-router-dom';
import Container from 'react-bootstrap/Container';
import Card from 'react-bootstrap/Card';
import ListGroup from 'react-bootstrap/ListGroup';
import Button from 'react-bootstrap/Button';
import '../../styles/ProfilePage.css';

const Profile = () => {
  const navigate = useNavigate();
  const [userProfile, setUserProfile] = useState(null);
  const [error, setError] = useState(null);

  useEffect(() => {
    const getProfile = async () => {
      try {
        const token = getToken();
        if (!token) {
          navigate('/login');
          return;
        }
        const config = {
          headers: { Authorization: `Bearer ${token}` },
        };
        const { data } = await axios.get('http://localhost:5245/api/auth/profile', config);
        setUserProfile(data);
      } catch (error) {
        console.error(error);
        setError('Failed to load profile');
      }
    };
    getProfile();
  }, [navigate]);

  if (error) {
    return <Container as="main" className="Profile-page"><h2>{error}</h2></Container>
  }

  return (
    <Container as="main" className="Profile-page">
      {userProfile ? (
        <div className="row">
          <div className="col-lg-4">
            <Card className="Profile-card">
              <Card.Body className="text-center">
                <img
                  src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava3.webp"
                  alt="avatar"
                  className="Profile-avatar mb-4"
                />
                <h5 className="mb-3">{userProfile.userName}</h5>
                <p className="Profile-fullname">{`${userProfile.firstName} ${userProfile.lastName}`}</p>
                <Button variant="primary" onClick={() => navigate('/edit-profile')}>Edit Profile</Button>
              </Card.Body>
            </Card>
          </div>
          <div className="col-lg-8">
            <Card className="Profile-card">
              <Card.Body>
                <ListGroup variant="flush">
                  <ListGroup.Item><strong>Full Name:</strong> {`${userProfile.firstName} ${userProfile.lastName}`}</ListGroup.Item>
                  <ListGroup.Item><strong>Email:</strong> {userProfile.email}</ListGroup.Item>
                  <ListGroup.Item><strong>Address:</strong> {`${userProfile.address}, ${userProfile.city}, ${userProfile.state} ${userProfile.postalCode}, ${userProfile.country}`}</ListGroup.Item>
                </ListGroup>
              </Card.Body>
            </Card>
          </div>
        </div>
      ) : (
        <h2>Loading...</h2>
      )}
    </Container>
  );
};

export default Profile;
