import React from 'react';
import { Routes, Route } from 'react-router-dom';
import EventHomePage from './components/Home/EventHomePage';
import EventsList from './components/EventsList';
import EventDetail from './components/EventDetail';
import RegisterPage from './components/Authorization/RegisterPage';
import LoginPage from './components/Authorization/LoginPage';
import UserProfile from './components/Authorization/UserProfile';

const AppRoutes = ({ isAuthenticated, setIsAuthenticated }) => (
  <Routes>
    <Route path='/' element={<EventHomePage />} />
    <Route path='/events' element={<EventsList />} />
    <Route path="/events/:id" element={<EventDetail />} />
    <Route path='/register' element={<RegisterPage />} />
    <Route path="/login" element={<LoginPage isAuthenticated={isAuthenticated} setIsAuthenticated={setIsAuthenticated} />} />
    <Route path="/profile/:userId" element={<UserProfile />} />
  </Routes>
);

export default AppRoutes;
