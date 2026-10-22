import type { Experience } from '../types'
import './ExperienceCard.css'

type ExperienceCardProps = {
  experience: Experience
}

function ExperienceCard({ experience }: ExperienceCardProps) {
  const { role, description, tech, dateFrom, dateTo, company, location } =
    experience
  return (
    <li className="experience-card">
      <div className="experience-header">
        <p className="experience-dates">
          {dateFrom} - {dateTo ?? 'Present'}
        </p>
        <p className="experience-location">{location}</p>
      </div>

      <div className="experience-body">
        <h3 className="experience-title">{role}</h3>
        <p className="experience-company">{company}</p>
        <ul className="experience-description">
          {description.map((item, index) => (
            <li key={index}>{item}</li>
          ))}
        </ul>
      </div>

      <ul className="experience-tech">
        {tech.map((skill) => (
          <li key={skill} className="tech-badge">
            {skill}
          </li>
        ))}
      </ul>
    </li>
  )
}

export default ExperienceCard
