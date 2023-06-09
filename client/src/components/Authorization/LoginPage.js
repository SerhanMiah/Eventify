import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import '../../styles/login.css';
import { useNavigate } from 'react-router-dom'
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form'
import Container from 'react-bootstrap/Container'
import Row from 'react-bootstrap/Row'
import Col from 'react-bootstrap/Col'
import axios from 'axios'

const LoginPage = () => {
  const navigate = useNavigate() 

  const [ loginData, setLoginData ] = useState({
    email: '',
    password: '',
  })
  const [ errors, setErrors ] = useState(false)

  const handleChange = (event) => {
    setLoginData({ ...loginData, [event.target.name]: event.target.value  })
  }

  const onSubmit = async (event) => {
    event.preventDefault()
    try {
      const { data } = await axios.post('http://localhost:5245/api/auth/login', loginData)
      console.log(data)
    
      navigate('/')
    } catch (error) {
      setErrors(error.message)
      console.log(error.message)
    }
  }

  return (
    <main className='form-login'>
      <Container>
        <Row className="justify-content-md-center">
          <Col xs={12} md={8} lg={6}>
            <div className="login-panel">
              <h1>Login</h1>
              <Form onSubmit={onSubmit} className='login-form'>
                <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>Email address</Form.Label>
                  <Form.Control type='email' name='email' placeholder='Enter email' onChange={handleChange} value={loginData.email} />   
                </Form.Group>

                <Form.Group className="mb-3" controlId="formBasicPassword">
                  <Form.Label>Password</Form.Label>
                  <Form.Control type='password' name='password' placeholder='Password' onChange={handleChange} value={loginData.password} />
                </Form.Group>

                <Button variant="primary" type="submit" block>
                  Submit
                </Button>

                {errors && <div className='error'>{errors}</div>}

                <div className="mt-3">
                  <Link to="/forgot-password">Forgot password?</Link>
                </div>

                <div className="mt-2">
                  Don't have an account? <Link to="/register">Register</Link>
                </div>
              </Form>
            </div>
          </Col>
        </Row>
      </Container>
    </main>     
  )
};

export default LoginPage;
