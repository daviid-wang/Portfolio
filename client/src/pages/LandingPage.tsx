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
      <p className="landing-intro">
        I'm David, a Software Engineering graduate from the University of
        Western Australia. I'm currently working as a freelance full-stack
        software developer for a private charter company. I build
        business-critical aviation features used in time-sensitive operations,
        from flight manifests and freight handling to passenger check-in and
        staff certification.
      </p>
      <div className="landing-actions">
        <Link to="/projects" className="button button-solid-blue">
          View my experience
        </Link>
        <Link to="/contact" className="link-arrow">
          Contact me <span aria-hidden="true">↗</span>
        </Link>
      </div>
    </section>
  )
}

export default LandingPage
