import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import './App.css';
import EventsList from './components/EventsList';
import EventDetail from './components/EventDetail';


function App() {
  return (
    <Router>
      <div className="App">
        <h1>hello world</h1>
        <Routes>
          <Route path='/events' element={<EventsList />} />
          <Route path="/events/:id" element={<EventDetail />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
