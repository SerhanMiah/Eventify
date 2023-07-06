import React, { useState, useEffect } from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import NavBar from './components/Navigation/NavigationBar';
import Login from './components/Authorization/LoginPage';
import Register from './components/Authorization/RegisterPage';
import Footer from './components/Navigation/Footer';
import EventHomePage from './components/Home/EventHomePage';
import ProfilePage from './components/Authorization/Profile';
import EventDetail from './components/EventDetail';

import { userIsAuthenticated, getId } from './components/helpers/auth';
import CreateEventForm from './components/Event/CreateEventForm';

function App() {
  const [userId, setUserId] = useState(getId());
  const [isAuthenticated, setIsAuthenticated] = useState(userIsAuthenticated());

  useEffect(() => {
    const handleStorageChange = () => {
      setUserId(getId());
      setIsAuthenticated(userIsAuthenticated());
    };

    window.addEventListener('storage', handleStorageChange);
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);

  return (
    <Router>
      <div className="App">
        <NavBar userId={userId} isAuthenticated={isAuthenticated} setIsAuthenticated={setIsAuthenticated} />
        <Routes>
          <Route path="/" element={<EventHomePage />} />
          <Route path="/login" element={!isAuthenticated ? <Login setIsAuthenticated={setIsAuthenticated} /> : <Navigate to="/" />} />
          <Route path="/register" element={!isAuthenticated ? <Register /> : <Navigate to="/" />} />
          <Route path="/profile/:id" element={<ProfilePage />} />
          <Route path="/events/:id" element={<EventDetail />} />
          <Route path="/events/createEvent" element={isAuthenticated ? <CreateEventForm /> : <Navigate to="/login" />} />
        </Routes>
        <Footer />
      </div>
    </Router>
  );
}

export default App;
