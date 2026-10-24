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
        <a
          href="/resume-october.pdf"
          download="David-Wang-Resume.pdf"
          className="navbar-resume"
        >
          Résumé
          <svg
            aria-hidden="true"
            width="16"
            height="16"
            viewBox="0 0 24 24"
            fill="none"
            stroke="currentColor"
            strokeWidth="2"
            strokeLinecap="round"
            strokeLinejoin="round"
          >
            <path d="M12 3v12" />
            <path d="M7 10l5 5 5-5" />
            <path d="M5 21h14" />
          </svg>
        </a>
      </nav>
    </header>
  )
}

export default NavBar
