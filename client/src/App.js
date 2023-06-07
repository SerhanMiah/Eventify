import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import './App.css';
// import './styles/main.css';
import EventHomePage from './components/Home/EventHomePage';
import EventsList from './components/EventsList';
import EventDetail from './components/EventDetail';
import NavigationBar from './components/Navigation/NavigationBar';


function App() {
  return (
    <Router>
      <div className="App">
        <NavigationBar />
        <Routes>
          <Route path='/' element={<EventHomePage />} />
          <Route path='/events' element={<EventsList />} />
          <Route path="/events/:id" element={<EventDetail />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
