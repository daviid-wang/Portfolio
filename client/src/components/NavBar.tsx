import { NavLink } from "react-router"
import "./NavBar.css"

function NavBar() {
  return (
      <nav>
        <NavLink to="/" end>Home</NavLink> | <NavLink to="/projects">Projects</NavLink> | <NavLink to="/skills">Skills</NavLink> | <NavLink to="/education">Education</NavLink> | <NavLink to="/contact">Contact</NavLink> | <NavLink to="/resume">Resume</NavLink>
      </nav>
  )
}

export default NavBar
