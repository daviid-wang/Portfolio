import { useEffect, useState } from 'react'
import type { Project } from './types'
import ProjectList from './components/ProjectList'

function App() {
  const [projects, setProjects] = useState<Project[]>([])
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    fetch('/api/projects')
      .then(res => {
        if (!res.ok) throw new Error(`HTTP ${res.status}`)
        return res.json()
      })
      .then(setProjects)
      .catch(err => setError(err.message))
  }, [])

  if (error) return <p>Error: {error}</p>

  return (
    <main>
      <h1>Projects</h1>
      <ProjectList projects={projects} />
    </main>
  )
}

export default App