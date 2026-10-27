import { Link } from 'react-router'
import Eyebrow from '../components/Eyebrow.tsx'
import './LandingPage.css'
import profilePhoto from '../assets/profile-photo.webp'

function LandingPage() {
  return (
    <section className="container">
      <Eyebrow
        label="Software Engineering Graduate / University of Western Australia"
        status="Seeking a graduate/junior software developer role"
      />
      <div className="page-hero landing-content">
        <div className="landing-text">
          <h1 className="title">
            Quality software. <br />
            Responsibly built.
          </h1>
          <p className="landing-intro">
            I'm David, a Software Engineering graduate from the University of
            Western Australia. I'm currently working as a freelance full-stack
            software developer for a private charter company. I build
            business-critical aviation features used in time-sensitive
            operations, from flight manifests and freight handling to passenger
            check-in and staff certification.
          </p>
          <div className="landing-actions">
            <Link to="/projects" className="button button-solid-blue">
              View my experience
            </Link>
            <Link to="/contact" className="link-arrow">
              Contact me <span aria-hidden="true">↗</span>
            </Link>
          </div>
        </div>
        <div className="landing-photo-wrap">
          <img
            src={profilePhoto}
            alt="David Wang"
            className="landing-photo"
            width={200}
            height={200}
          />
        </div>
      </div>
    </section>
  )
}

export default LandingPage
