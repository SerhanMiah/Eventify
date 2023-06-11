import React, { useState, useEffect } from 'react';
import { Navbar, Nav, Container, NavDropdown } from 'react-bootstrap';
// import { LinkContainer } from 'react-router-bootstrap';
// import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
// import { faUser } from '@fortawesome/free-solid-svg-icons';
import { userIsAuthenticated } from '../helpers/auth';

import { Link, useNavigate, useParams } from 'react-router-dom'

const NavigationBar = ({userId}) => {
  const [isAuthenticated, setIsAuthenticated] = useState(userIsAuthenticated());

  useEffect(() => {
    const handleStorageChange = () => {
      setIsAuthenticated(userIsAuthenticated());
    };

    window.addEventListener('storage', handleStorageChange);
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);

  const handleLogOut = () => {
    console.log('Logging out...');
    window.localStorage.removeItem('local-user-Token');
    setIsAuthenticated(false);
  };

  return (
    <Nav variant="tabs" defaultActiveKey="/home">
      <Nav.Item>
        <Nav.Link style={{ textDecoration: 'none', color: 'black', padding: '10px, 30px' }} as={Link} to='/' >Home</Nav.Link> 
      </Nav.Item>
      
      <Nav.Item>
        <Nav.Link style={{ textDecoration: 'none', color: 'black', padding: '10px, 30px' }} as={Link} to='/theatre' >All theatre</Nav.Link>
      </Nav.Item>

     

     
      { userIsAuthenticated()
        ?
        <>
          <Nav.Item>
            <Nav.Link style={{ textDecoration: 'none', color: 'black', padding: '10px, 30px' }} as={Link} to='/profile/' >User Profile</Nav.Link>
          </Nav.Item>
          <Nav.Item>
            <Nav.Link style={{ textDecoration: 'none', color: 'black', padding: '10px, 30px' }}  onClick={handleLogOut}>Logout</Nav.Link>
          </Nav.Item>
        </>
        :
        <>
          <Nav.Item>
            <Nav.Link style={{ textDecoration: 'none', color: 'black', padding: '10px, 30px' }} as={Link} to='/register'>Register</Nav.Link>
          </Nav.Item>
          <Nav.Item>
            <Nav.Link style={{ textDecoration: 'none', color: 'black', padding: '10px, 30px' }} as={Link} to='/login'>Login</Nav.Link>
          </Nav.Item>
        </>      
      }      
    </Nav>
  )
}

export default NavigationBar;
