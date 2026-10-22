import { useEffect, useState } from 'react'
import type { Project } from '../types'
import ProjectList from '../components/ProjectList'
import Eyebrow from '../components/Eyebrow'
import './ProjectsPage.css'
import { Link } from 'react-router'

function ProjectsPage() {
  const [projects, setProjects] = useState<Project[] | null>(null)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    fetch('/api/projects')
      .then((res) => {
        if (!res.ok) throw new Error(`HTTP ${res.status}`)
        return res.json()
      })
      .then(setProjects)
      .catch((err) => setError(err.message))
  }, [])

  return (
    <section className="container">
      <Eyebrow label="Experience & Projects" />
      <header className="page-hero projects-summary">
        <h1 className="title">
          Work that runs <br />
          real operations.
        </h1>
        <p className="projects-text">
          Production software I've built for a charter airline, alongside
          projects that show how I design, test and ship full-stack features.
        </p>
      </header>
      <div className="projects-actions">
        <a href="#experience" className="button button-transparent-gray-border">
          Experience
        </a>
        <a href="/projects" className="button button-transparent-gray-border">
          Projects
        </a>
      </div>
      <section className="experience" id="experience">
        <h1 className="sub-title">Experience</h1>
        {error && <p>Error: {error}</p>}
        {!error && projects === null && <p>Loading projects...</p>}
        {projects && <ProjectList projects={projects} />}
      </section>
    </section>
  )
}

export default ProjectsPage
