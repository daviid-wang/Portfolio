import './ContactPage.css'

import Eyebrow from '../components/Eyebrow.tsx'

function ContactPage() {
  return (
    <section className="container">
      <Eyebrow label="Contact / David Wang" status="Seeking a graduate/junior software developer role" />
      <div className="page-hero contact-content">
        <h1 className="title">
          Hiring a graduate <br /> developer?
        </h1>
        <p className="contact-text">
          I'm looking for a graduate or junior developer role, ideally in
          full-stack development. The quickest way to reach me is email, and I
          usually reply within a day.
        </p>
      </div>
      <a
        href="david.wang9524@gmail.com"
        className="button button-solid-blue"
      >
        Get in Touch
      </a>
    </section>
  )
}

export default ContactPage
