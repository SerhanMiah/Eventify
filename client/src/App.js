import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import EventHomePage from './components/Home/EventHomePage';
import EventsList from './components/EventsList';
import EventDetail from './components/EventDetail';
import NavigationBar from './components/Navigation/NavigationBar';
import RegisterPage from './components/Authorization/RegisterPage';
import LoginPage from './components/Authorization/LoginPage';
import Footer from './components/Navigation/Footer';
import { userIsAuthenticated } from './components/helpers/auth';
import UserProfile from './components/UserProfile';


function App() {
  const [isAuthenticated, setIsAuthenticated] = useState(userIsAuthenticated);

  return (
    <Router>
      <div className="App">
        <NavigationBar isAuthenticated={isAuthenticated} setIsAuthenticated={setIsAuthenticated} />
        <Routes>
          <Route path='/' element={<EventHomePage />} />
          <Route path='/events' element={<EventsList />} />
          <Route path="/events/:id" element={<EventDetail />} />
          <Route path='/register' element={<RegisterPage />} />
          <Route path="/login" element={<LoginPage isAuthenticated={isAuthenticated} setIsAuthenticated={setIsAuthenticated} />} />
          <Route path="/profile/:userId" element={<UserProfile />} />
        </Routes>
      </div>
      <Footer />
    </Router>
  );
}

export default App;
