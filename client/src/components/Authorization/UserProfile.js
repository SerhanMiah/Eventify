import axios from 'axios';
import { useEffect, useState } from 'react';
import { getToken } from '../helpers/auth.js';
import Container from 'react-bootstrap/Container';
import { Link } from 'react-router-dom';
import Form from 'react-bootstrap/Form';
import { Button } from 'react-bootstrap';
import { Card } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import { getUserIdFromToken, getId } from '../helpers/auth.js';


const ProfilePage = () => {
  const navigate = useNavigate();
  const [user, setUser] = useState(null);
  const userId = getUserIdFromToken();

  
  const [userProfile, setUserProfile] = useState(null);
  const [errors, setErrors] = useState(false);
  const [updatedUserProfile, setUpdatedUserProfile] = useState('');

  async function fetchUser() {
    const userId = getId();  // get userId from local storage
    if (!userId) {
      console.log('User id is undefined');
      return;
    }
  
    try {
      const response = await axios.get(`http://localhost:5245/api/users/${userId}`, {
        headers: { Authorization: `Bearer ${getToken()}` },
      });
      
      if (response.status === 200) {
        setUser(response.data); // update the user state with the fetched user data
      }
    } catch (error) {
      console.log('Error fetching user:', error);
    }
  }
  useEffect(() => {
    fetchUser();
  }, []);
  

  return (
    <Container as='main' className='Profile-page'>
      <div className='display'>
      {user ? (
        <div className="container">
          <div className="fb-profile">
            {/* <Card.Img align="left" className="fb-image-profile thumbnail"  src={user.profile_image} alt={user.username} /> */}
            <div className="fb-profile-text">
              <Card.Body>
                <Card.Title><h1> HI, {user.FirstName}</h1></Card.Title>
                <Card.Text>
                  <h1>Welcome, {user.FirstName} </h1>
                  {user.bio}
                </Card.Text>
                <Link to={`/profileEdit/${user.id}`} className='btn btn-primary'>Edit Profile</Link>
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
