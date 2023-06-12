import React from 'react';
import '../../styles/footer.css';

const Footer = () => {
  return (
    <footer className="footer-container bg-light mt-auto py-3 text-center">
      <div className="container">
        <span className="text-muted">
          Created by: 
          <a className="gitLink text-info ml-2" href="https://github.com/SerhanMiah" target="_blank" rel="noreferrer">
            <i className="fab fa-github"></i> Serhan Miah
          </a>
        </span>
      </div>
    </footer>
  );
};

export default Footer;
