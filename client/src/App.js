import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

// import './styles/main.css';
import EventHomePage from './components/Home/EventHomePage';
import EventsList from './components/EventsList';
import EventDetail from './components/EventDetail';
import NavigationBar from './components/Navigation/NavigationBar';
import RegisterPage from './components/Authorization/RegisterPage';
import LoginPage from './components/Authorization/LoginPage';
import Footer from './components/Navigation/Footer';

function App() {
  return (
    <Router>
      <div className="App">
        <NavigationBar />
        <Routes>
          <Route path='/' element={<EventHomePage />} />
          <Route path='/events' element={<EventsList />} />
          <Route path="/events/:id" element={<EventDetail />} />
          <Route path='/register' element={<RegisterPage />} />
          <Route path="/login" element={<LoginPage />} />
        </Routes>
      </div>
      <Footer />
    </Router>
  );
}

export default App;
