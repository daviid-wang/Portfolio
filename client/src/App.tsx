import { Routes, Route, Link } from 'react-router'
import LandingPage from './pages/LandingPage'
import ProjectsPage from './pages/ProjectsPage'
import NotFoundPage from './pages/NotFoundPage'

function App() {
  return (
    <>
      <nav>
        <Link to="/">Home</Link> | <Link to="/projects">Projects</Link>
      </nav>

      <main>
        <Routes>
          <Route path="/" element={<LandingPage />} />
          <Route path="/projects" element={<ProjectsPage />} />
          <Route path="*" element={<NotFoundPage />} />
        </Routes>
      </main>
    </>
  )
}
export default App
