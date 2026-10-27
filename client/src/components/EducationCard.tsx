import type { Education } from '../types'
import './EducationCard.css'

type educationCardProps = {
  education: Education
}

function EducationCard({ education }: educationCardProps) {
  const {
    degree,
    university,
    location,
    dateFrom,
    dateTo,
    status,
    summary,
    scholarship,
    highlights,
    units,
  } = education
  return (
    <article className="education-wrap">
      <div>
        <p className="education-dates">
          {dateFrom} - {dateTo}
        </p>
        <p className="label label-muted">
          {location} · {status}
        </p>
      </div>
      <div className="education-content">
        <div>
          <h2>{degree}</h2>
          <p className="education-university">{university}</p>
        </div>

        {summary && <p className="education-summary">{summary}</p>}

        {scholarship && (
          <div className="education-scholarship">
            <span className="education-scholarship-icon" aria-hidden="true">
              ★
            </span>
            <div>
              <p className="education-scholarship-title">{scholarship.title}</p>
              <p>{scholarship.description}</p>
            </div>
          </div>
        )}

        {highlights.length > 0 && (
          <div>
            <p className="label label-muted">Highlights</p>
            <ul className="education-highlights">
              {highlights.map((h) => (
                <li key={h.title} className="education-highlight">
                  <p className="label label-accent">{h.eyebrow}</p>
                  <h3>{h.title}</h3>
                  <p>{h.description}</p>
                  <ul className="education-tags">
                    {h.tech.map((t) => (
                      <li key={t}>{t}</li>
                    ))}
                  </ul>
                </li>
              ))}
            </ul>
          </div>
        )}
        <div>
          <p className="label label-muted">
            {status === 'Completed' ? 'Relevant coursework' : 'Units included'}
          </p>
          <ul className="education-tags">
            {units.map((u) => (
              <li key={u}>{u}</li>
            ))}
          </ul>
        </div>
      </div>
    </article>
  )
}

export default EducationCard
