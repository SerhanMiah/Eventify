
import { Buffer } from 'buffer'

export const setToken = (token) => {
  window.localStorage.setItem('local-user-Token', token)
}
export const setId = (id) => {
  console.log('Setting user id: ', id); 
  window.localStorage.setItem('local-user-Id', id)
}

export const getToken = () => {
  return window.localStorage.getItem('local-user-Token')
}

export const getId = () => {
  const id = window.localStorage.getItem('local-user-Id');
  console.log('Getting user id: ', id);  // Add this
  return id;
}

export const getPayLoad = () => {
  const token = getToken()
  console.log(token)
  if (!token) return 
  const splitToken = token.split('.')
  if (splitToken.length !== 3) return 
  return JSON.parse(Buffer.from(splitToken[1], 'base64'))
}

export const userIsAuthenticated = () => {
  const payload = getPayLoad()
  if (!payload) return false
  const currentTime = Math.round(Date.now() / 1000) 
  return currentTime < payload.exp
}


export const userIsOwner = (item) => {
  const payload = getPayLoad()
  if (!payload) return
  return payload.userId === item.createdBy 
}

export const getUserIdFromToken = () => {
  const token = getToken();
  if (!token) return null;
  const splitToken = token.split('.');
  if (splitToken.length !== 3) return null;
  const payload = JSON.parse(Buffer.from(splitToken[1], 'base64'));
  return payload.userId; // Assuming the user id is saved in the payload as 'userId'
}
