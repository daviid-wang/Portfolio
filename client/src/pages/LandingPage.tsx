import { Link } from 'react-router'
import Eyebrow from '../components/Eyebrow.tsx'
import './LandingPage.css'

function LandingPage() {
  return (
    <section>
      <Eyebrow
        label="Software Engineering Graduate / University of Western Australia"
        status="Seeking a graduate/junior software developer role"
      />
      <h1 className="landing-title">
        Quality software. <br />
        Responsibly built.
      </h1>

      <p>Full-stack developer working with C#, ASP.NET Core and React.</p>
      <Link to="/projects">See my projects</Link>
    </section>
  )
}

export default LandingPage
