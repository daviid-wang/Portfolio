import type { Project } from '../types'
import './ProjectCard.css'

type ProjectCardProps = {
  project: Project
}

function ProjectCard({ project }: ProjectCardProps) {
  const { title, eyebrow, description, tech, links } = project

  return (
    <li className="project-card">
      <p className="label label-accent">{eyebrow}</p>
      <h3 className="project-card-title">{title}</h3>
      <p className="project-card-description">{description}</p>

      <ul className="project-card-tech">
        {tech.map((t) => (
          <li key={t} className="project-card-tag">
            {t}
          </li>
        ))}
      </ul>

      <div className="project-card-links">
        {links.map((link) => (
          <a key={link.url} href={link.url} className="link-arrow" target="_blank" rel="noopener noreferrer">
            {link.label} <span aria-hidden="true">↗</span>
          </a>
        ))}
      </div>
    </li>
  )
}

export default ProjectCard
