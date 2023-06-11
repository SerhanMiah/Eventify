import React, { useState, useEffect } from 'react';
import axios from 'axios';

const UserProfile = ({ userId }) => {
  const [userData, setUserData] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(`http://localhost:5245/api/users/${userId}`);
        setUserData(response.data);
      } catch (error) {
        console.error('Error fetching user data:', error);
      }
    };

    fetchData();
  }, [userId]);

  if (!userData) {
    return <div>Loading...</div>;
  }

  return (
    <div className="user-profile">
      <h2>User Profile</h2>
      <p><strong>Name:</strong> {userData.firstName} {userData.lastName}</p>
      <p><strong>Email:</strong> {userData.email}</p>
      <p><strong>Address:</strong> {userData.address}</p>
      <p><strong>City:</strong> {userData.city}</p>
      <p><strong>Country:</strong> {userData.country}</p>
      <p><strong>Date of Birth:</strong> {new Date(userData.dateOfBirth).toDateString()}</p>
      {userData.profilePictureUrl && <img src={userData.profilePictureUrl} alt="Profile" />}
    </div>
  );
};

export default UserProfile;
