import type { Project } from '../types'

type ProjectCardProps = {
    project: Project
}

function ProjectCard({ project }: ProjectCardProps) {
    return (
        <li>
        <strong>{project.title}</strong>: {project.description}
        <p>Built with: {project.tech.join(', ')}</p>
        </li>
    )
}

export default ProjectCard