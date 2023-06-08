import React from 'react';
import { Nav, Navbar, Container, NavDropdown } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import '../../styles/navigation.css';

const NavigationBar = () => {
    return (
        <Navbar bg="dark" variant="dark" expand="lg">
            <Container>
                <LinkContainer to="/">
                    <Navbar.Brand>Eventify</Navbar.Brand>
                </LinkContainer>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav" className="justify-content-center">
                    <Nav className="me-auto">
                        <LinkContainer to="/">
                            <Nav.Link>Home</Nav.Link>
                        </LinkContainer>
                        <LinkContainer to="/events">
                            <Nav.Link>Events</Nav.Link>
                        </LinkContainer>
                        {/* Add more navigation links as needed */}
                    </Nav>
                    <Nav className="ml-auto">
                        <LinkContainer to="/register">
                            <Nav.Link>Register</Nav.Link>
                        </LinkContainer>
                        <LinkContainer to="/login">
                            <Nav.Link>Login</Nav.Link>
                        </LinkContainer>
                        <NavDropdown title="Account" id="basic-nav-dropdown">
                            <NavDropdown.Item href="#action/3.1">Profile</NavDropdown.Item>
                            <NavDropdown.Item href="#action/3.2">Settings</NavDropdown.Item>
                            <NavDropdown.Divider />
                            <NavDropdown.Item href="#action/3.3">Logout</NavDropdown.Item>
                        </NavDropdown>
                    </Nav>
                </Navbar.Collapse>
            </Container>
        </Navbar>
    );
};

export default NavigationBar;
