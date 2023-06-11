import React, { useState, useEffect } from 'react';
import { Navbar, Nav, Container, NavDropdown } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser } from '@fortawesome/free-solid-svg-icons';
import { userIsAuthenticated } from '../helpers/auth';

const NavigationBar = () => {
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
      console.log("Logging out...");
      window.localStorage.removeItem('local-user-Token');
      setIsAuthenticated(false);
  };

  return (
    <div className="navigation">
      <div className="navbar-top">
        <Navbar bg="dark" variant="dark" expand="lg">
          <Container>
            <LinkContainer to="/">
              <Navbar.Brand>Eventify</Navbar.Brand>
            </LinkContainer>
            <Navbar.Toggle aria-controls="main-navbar-nav" />
            <Navbar.Collapse id="main-navbar-nav" className="justify-content-center">
              <Nav className="me-auto">
              {/* Add more links if need be */}
              </Nav>
              <Nav className="ml-auto">
              { isAuthenticated
                  ?
                  <>
                      <NavDropdown title="Account" id="basic-nav-dropdown">
                          <NavDropdown.Item href="#action/3.1">Profile</NavDropdown.Item>
                          <NavDropdown.Item href="#action/3.2">Settings</NavDropdown.Item>
                          <NavDropdown.Divider />
                          <NavDropdown.Item onClick={handleLogOut}>Logout</NavDropdown.Item>
                      </NavDropdown>
                  </>
                  :
                  <>
                      <LinkContainer to="/register">
                          <Nav.Link><FontAwesomeIcon icon={faUser} /> Register</Nav.Link>
                      </LinkContainer>
                      <LinkContainer to="/login">
                          <Nav.Link><FontAwesomeIcon icon={faUser} /> Login</Nav.Link>
                      </LinkContainer>
                  </>
              }
              </Nav>
            </Navbar.Collapse>
          </Container>
        </Navbar>
      </div>
    </div>
  );
};

export default NavigationBar;
