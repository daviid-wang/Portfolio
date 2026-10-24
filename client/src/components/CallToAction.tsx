import { Link } from 'react-router'
import './CallToAction.css'

function CallToAction() {
  return (
    <section className="cta" aria-labelledby="cta-heading">
      <div>
        <p className="label label-muted">Next steps</p>
        <h2 id="cta-heading" className="cta-heading">
          Looking for a junior developer?
        </h2>
      </div>

      <div className="cta-actions">
        <Link to="/contact" className="button button-solid-blue">
          Contact me
        </Link>
        <a href="/resume-october.pdf" className="link-arrow" download="David-Wang-Resume.pdf">
          Download résumé <span aria-hidden="true">↓</span>
        </a>
      </div>
    </section>
  )
}

export default CallToAction
