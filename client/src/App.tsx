import { Routes, Route, Link } from 'react-router'
import LandingPage from './pages/LandingPage'
import ProjectsPage from './pages/ProjectsPage'
import NotFoundPage from './pages/NotFoundPage'
import NavBar from './components/NavBar'

function App() {
  return (
    <>
    <NavBar />
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
