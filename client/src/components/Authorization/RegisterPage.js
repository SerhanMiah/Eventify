import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import Container from 'react-bootstrap/Container'
import Row  from 'react-bootstrap/Row'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'

import '../../styles/register.css';

const RegisterPage = () => {
  const navigate = useNavigate();
  const [errors, setErrors] = useState('');
  const [formData, setFormData] = useState({
    firstName: '',
    lastName: '',
    userName: '',
    email: '',
    password: '',
    password_confirmation: ''
  });

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = async (event) => {
    event.preventDefault();
    if(formData.password !== formData.password_confirmation){
      setErrors('Password and Confirm Password do not match.');
      return;
    }
    try {
      const { data } = await axios.post('http://localhost:5245/api/register', formData);
      console.log(data);
      navigate('/login');
    } catch (error) {
      setErrors(error.response.data);
      console.log(error.response.data);
    }
  };

  return (
    <main className='form-page'>
      <Container className='register-form' as='main'>
        <Row>
          <h1>Register</h1>    
          
          <Form onSubmit={handleSubmit}>
            <Form.Group className="mb-3" >
              <Form.Label>First Name</Form.Label>
              <Form.Control  onChange={handleChange} type="text" name="first_name" placeholder='Enter your name' value={formData.first_name}  />
              <Form.Text className="text-muted">
                  Wll never share your email with anyone else.
              </Form.Text>
            </Form.Group>

            <Form.Group className="mb-3" >
              <Form.Label>Last Name</Form.Label>
              <Form.Control  onChange={handleChange} type="text" name="last_name" placeholder='Enter your name' value={formData.last_name}  />
              <Form.Text className="text-muted">
                  Wll never share your email with anyone else.
              </Form.Text>
            </Form.Group>

            <Form.Group className="mb-3" >
              <Form.Label>User Name</Form.Label>
              <Form.Control onChange={handleChange} type="text" name="username" placeholder="username" value={formData.userName} /> 
            </Form.Group>

            <Form.Group className="mb-3" >
              <Form.Label>Email address</Form.Label>
              <Form.Control  onChange={handleChange} type="email" name="email" placeholder='Email' value={formData.email}  />
              <Form.Text className="text-muted">
                  Wll never share your email with anyone else.
              </Form.Text>
            </Form.Group>

            <Form.Group className="mb-3" >
              <Form.Label>Password</Form.Label>
              <Form.Control onChange={handleChange} type="password" name="password" placeholder='Password' value={formData.password}  />
            </Form.Group>

            <Form.Group className="mb-3" >
              <Form.Label>Confirm Password</Form.Label>
              <Form.Control onChange={handleChange} type="password" name="password_confirmation" placeholder='Confirm Password' value={formData.password_confirmation} /> 
            </Form.Group>

            { errors && <p className='text-danger'>{errors}</p>}

            <Button variant="primary" type="submit">
              Submit
            </Button>
          </Form>

        </Row>
      </Container>
    </main>

  )
};

export default RegisterPage;
