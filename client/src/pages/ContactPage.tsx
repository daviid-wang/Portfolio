import './ContactPage.css'

import Eyebrow from '../components/Eyebrow.tsx'

const socials = [
  { label: 'Phone', text: '0423 951 768', href: 'tel:+61423951768' },
  {
    label: 'LinkedIn',
    text: 'linkedin.com/in/david-wang-2b9931248',
    href: 'https://www.linkedin.com/in/david-wang-2b9931248/',
  },
  {
    label: 'GitHub',
    text: 'github.com/daviid-wang',
    href: 'https://github.com/daviid-wang',
  },
]

const facts = [
  { term: 'Location', value: 'Perth, Western Australia' },
  { term: 'Mobility', value: 'Open to relocation' },
  { term: 'Work rights', value: 'Australian citizen' },
]

function ContactPage() {
  return (
    <>
      <section className="container">
        <Eyebrow
          label="Contact"
          status="Seeking a graduate/junior software developer role"
        />
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
        <div className="contact-actions">
          <div>
            <p className="label label-accent">Email</p>
            <a href="mailto:david.wang9524@gmail.com" className="contact-email">
              david.wang9524@gmail.com
            </a>
          </div>
          <a
            href="mailto:david.wang9524@gmail.com"
            className="button button-solid-blue"
          >
            Send an email <span aria-hidden="true">↗</span>
          </a>
        </div>
        <ul className="contact-socials">
          {socials.map((s) => {
            const external = s.href.startsWith('http')
            return (
              <li key={s.label}>
                <a
                  href={s.href}
                  className="contact-social-link"
                  {...(external && {
                    target: '_blank',
                    rel: 'noopener noreferrer',
                  })}
                >
                  <span>
                    <span className="label label-accent">{s.label}</span>
                    <span className="contact-social-value">{s.text}</span>
                  </span>
                  <span className="contact-social-arrow" aria-hidden="true">
                    ↗
                  </span>
                </a>
              </li>
            )
          })}
        </ul>
      </section>
      <section
        className="contact-details-band"
        aria-labelledby="looking-for-heading"
      >
        <div className="container contact-details">
          <div>
            <p className="label label-accent">What I'm looking for</p>
            <h2 id="looking-for-heading" className="contact-details-heading">
              A place to contribute.
              <br />
              Room to keep learning.
            </h2>
            <p className="contact-details-text">
              I'm especially interested in full-stack web development. I
              value thoughtful code review, asking good questions and building
              reliable software with careful testing.
            </p>
          </div>

          <div>
            <p className="label label-muted">At a glance</p>
            <dl className="glance-list">
              {facts.map((f) => (
                <div key={f.term} className="glance-item">
                  <dt className="label label-muted">{f.term}</dt>
                  <dd>{f.value}</dd>
                </div>
              ))}
            </dl>
            <p className="glance-note">Referees available on request.</p>
          </div>
        </div>
      </section>
    </>
  )
}

export default ContactPage
