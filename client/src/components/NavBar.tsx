import { Link, NavLink } from 'react-router'
import './NavBar.css'

function NavBar() {
  return (
    <header className="navbar">
      <Link to="/" className="navbar-brand">
        <span className="navbar-logo">dw.</span>
        <span className="navbar-name">David Wang</span>
      </Link>
      <nav className="navbar-links">
        <NavLink to="/">Home</NavLink>
        <NavLink to="/projects">Projects</NavLink>
        <NavLink to="/skills">Skills</NavLink>
        <NavLink to="/education">Education</NavLink>
        <NavLink to="/contact">Contact</NavLink>
        <NavLink to="/resume">Resume</NavLink>
      </nav>
    </header>
  )
}

export default NavBar
