import React, { useState, useEffect } from 'react';
import { Navbar, Nav, Container, NavDropdown } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser } from '@fortawesome/free-solid-svg-icons';
import { userIsAuthenticated, getId } from '../helpers/auth';
import '../../styles/navigation.css'
import { useParams } from 'react-router-dom';

const NavigationBar = () => {
  const [isAuthenticated, setIsAuthenticated] = useState(userIsAuthenticated());
  const [userId, setUserId] = useState(getId());
  const { id } = useParams();

  useEffect(() => {
    const handleStorageChange = () => {
      setIsAuthenticated(userIsAuthenticated());
      setUserId(getId());
    };

    window.addEventListener('storage', handleStorageChange);
    return () => {
      window.removeEventListener('storage', handleStorageChange);
    };
  }, []);

  const handleLogOut = () => {
    window.localStorage.removeItem('local-user-Token');
    setIsAuthenticated(false);
    setUserId(null);
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
            <Navbar.Collapse id="main-navbar-nav" className="justify-content-end">
              <Nav className="ml-auto">
                { isAuthenticated
                  ?
                  <>
                    <NavDropdown title="Account" id="basic-nav-dropdown">
                      <LinkContainer to={`/profile/`}>
                        <NavDropdown.Item>Profile</NavDropdown.Item>
                      </LinkContainer>
                      <LinkContainer to={`/profile/${userId}/settings`}>
                        <NavDropdown.Item>Settings</NavDropdown.Item>
                      </LinkContainer>
                      <LinkContainer to={`/events/createEvent`}>
                        <NavDropdown.Item>Create Event</NavDropdown.Item>
                      </LinkContainer>
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
