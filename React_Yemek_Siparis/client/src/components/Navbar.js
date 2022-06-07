import React from 'react'

function Navbar() {
  return (
    <nav className="navbar navbar-expand-lg navbar-light bg-dark shadow-lg p-3 mb-5">
        <div className="container-fluid">
          <a className="navbar-brand" href="#">
            Web7 Foods
          </a>
          <button
            className="navbar-toggler bg-light"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNav"
            aria-controls="navbarNav"
            aria-expanded="false"
          >
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav ms-auto">
              <li className="nav-item">
                <a className="nav-link" href="#">
                  Giriş
                </a>
              </li>
              <li className="nav-item">
                <a className="nav-link" href="#">
                  Sepet
                </a>
              </li>
            </ul>
          </div>
        </div>
      </nav>
  )
}

export default Navbar