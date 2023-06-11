import axios from 'axios';
import { useEffect, useState } from 'react';
import { getToken } from '../helpers/auth.js';
import Container from 'react-bootstrap/Container';
import { Link } from 'react-router-dom';
import Form from 'react-bootstrap/Form';
import { Button } from 'react-bootstrap';
import { Card } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';

const ProfilePage = () => {
  const navigate = useNavigate();
  const { userId } = useParams();
  
  const [userProfile, setUserProfile] = useState(null);
  const [errors, setErrors] = useState(false);
  const [updatedUserProfile, setUpdatedUserProfile] = useState('');

  const getProfile = async () => {
    try {
      const { data } = await axios.get(`http://localhost:5245/api/users/${userId}`,  {
        headers: { Authorization: `Bearer ${getToken()}` },
      });
      
      setUserProfile(data);
      setUpdatedUserProfile(data);
    } catch (error) {
      console.error(error);
      setErrors(true);
    }
  };

  useEffect(() => {
    getProfile();
  }, []);

  return (
    <Container as='main' className='Profile-page'>
      <div className='display'>
        {userProfile ? (
          <div className="container">
            <div className="fb-profile">
              <Card.Img align="left" className="fb-image-profile thumbnail"  src={userProfile.profile_image} alt={userProfile.username} />
              <div className="fb-profile-text">
                <Card.Body>
                  <Card.Title><h1> HI, {userProfile.FirstName}</h1></Card.Title>
                  <Card.Text>
                    <h1>Welcome, {userProfile.FirstName} </h1>
                    {userProfile.bio}
                  </Card.Text>
                  <Link to={`/profileEdit/${userProfile.id}`} className='btn btn-primary'>Edit Profile</Link>
                </Card.Body>
              </div>
            </div>
          </div>
        )  : (
          <>
            {errors ? <h2>Oops something went wrong.</h2> : <h2>Loading...</h2>}
          </>
        )}
      </div>
    </Container>
  );
};

export default ProfilePage;
