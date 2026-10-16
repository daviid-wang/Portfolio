import { NavLink } from "react-router"

function NavBar() {
  return (
      <nav>
        <NavLink to="/" end>Home</NavLink> | <NavLink to="/projects">Projects</NavLink>
      </nav>
  )
}

export default NavBar
