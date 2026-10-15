import { Link } from 'react-router'

function LandingPage() {
  return (
    <section>
      <h1>Hi, I'm David</h1>
      <p>Full-stack developer working with C#, ASP.NET Core and React.</p>
      <Link to="/projects">See my projects</Link>
    </section>
  )
}

export default LandingPage
