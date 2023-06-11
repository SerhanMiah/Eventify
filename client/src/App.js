import React, { useState, useEffect } from 'react';
import { BrowserRouter as Router } from 'react-router-dom';
import NavigationBar from './components/Navigation/NavigationBar';
import Footer from './components/Navigation/Footer';
import { userIsAuthenticated } from './components/helpers/auth';
import AppRoutes from './AppRoutes';
import { getId } from './components/helpers/auth';

function App() {
  const [userId, setUserId] = useState(null);
  const [isAuthenticated, setIsAuthenticated] = useState(userIsAuthenticated);

  useEffect(() => {
    const currentUserId = getId(); 
    setUserId(currentUserId);
  }, []);


  return (
    <Router>
      <div className="App">
        <NavigationBar userId={userId} isAuthenticated={isAuthenticated} setIsAuthenticated={setIsAuthenticated} />
        <AppRoutes isAuthenticated={isAuthenticated} setIsAuthenticated={setIsAuthenticated} />
        <Footer />
      </div>
    </Router>
  );
}

export default App;
