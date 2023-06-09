import React from 'react';
import { Nav, Navbar, Container, NavDropdown } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser } from '@fortawesome/free-solid-svg-icons';
import '../../styles/navigation.css';
import { useNavigate } from "react-router-dom";
import { userIsAuthenticated } from '../helpers/auth';


const NavigationBar = () => {
    const navigate = useNavigate();

    const handleLogOut = () => {
        window.localStorage.removeItem('local-user-Token')
        navigate('/')
    };

    const isAuthenticated = userIsAuthenticated();

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
                                {/* Add more navigation links as needed */}
                            </Nav>
                            <Nav className="ml-auto">
                            { userIsAuthenticated
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
