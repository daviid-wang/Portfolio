import type { Experience } from '../types'
import './ExperienceCard.css'

type ExperienceCardProps = {
  experience: Experience
}

function ExperienceCard({ experience }: ExperienceCardProps) {
  const { role, description, tech, dateFrom, dateTo, company, location } = experience;
  return (
    <div className="experience-card">
      <h3 className="card-title">{role}</h3>
      <p className="card-company">{company}</p>
      <p className="card-location">{location}</p>
      <p className="card-dates">
        {dateFrom} - {dateTo || "Present"}
      </p>
      <ul className="card-description">
        {description.map((item, index) => (
          <li key={index}>{item}</li>
        ))}
      </ul>
      <div className="card-tech">
        {tech.map((skill, index) => (
          <span key={index} className="tech-badge">
            {skill}
          </span>
        ))}
      </div>
    </div>
  )
}

export default ExperienceCard
