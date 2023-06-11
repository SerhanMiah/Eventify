import axios from 'axios'
import { useEffect, useState } from 'react'
import Container from 'react-bootstrap/Container'

import { Link } from 'react-router-dom'
import { Card } from 'react-bootstrap'
import { useNavigate, useParams } from 'react-router-dom'
// import mainPicture from '../../img/cw-49089.jpeg'

const ProfilePage = () => {
  const navigate = useNavigate()
  const [ userProfile, setUserProfile ] = useState(null)
  const { userId } = useParams()

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(`http://localhost:5245/api/users/${userId}/`);
        setUserProfile(response.data);
      } catch (error) {
        console.error('Error fetching user data:', error);
      }
    };

    fetchData();
  }, [userId]);

  if (!userProfile) {
    return <div>Loading...</div>;
  }

  return (
    <Container as='main' className='Profile-page'>
      <div className='display'>
        <div className="container">
          <div className="fb-profile">

            {/* <img align="left" className="fb-image-lg" src={mainPicture} alt="Profile image example"/> */}
            <Card.Img align="left" className="fb-image-profile thumbnail"  src={userProfile.profilePictureUrl} alt={userProfile.username} />

            <div className="fb-profile-text">
              <Card.Body>
                <Card.Title><h1> HI, {userProfile.username}</h1></Card.Title>
                <Card.Text>
                  <h1>Welcome, {userProfile.name} </h1>
                  {userProfile.bio}
                </Card.Text>
                <Link to={`/profileEdit/${userProfile.id}`} className='btn btn-primary'>Edit Profile</Link>

              </Card.Body>
            </div>
          </div>
        </div>
      </div>
    </Container>
  )
}

export default ProfilePage
