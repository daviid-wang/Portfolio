import { Routes, Route, useLocation } from 'react-router'
import LandingPage from './pages/LandingPage'
import ProjectsPage from './pages/ProjectsPage'
import SkillsPage from './pages/SkillsPage'
import ContactPage from './pages/ContactPage'
import NotFoundPage from './pages/NotFoundPage'
import NavBar from './components/NavBar'

import Footer from './components/Footer'

function App() {
  const { pathname } = useLocation()
  const showFooter = pathname !== '/'

  return (
    <>
      <NavBar />
      <main>
        <Routes>
          <Route path="/" element={<LandingPage />} />
          <Route path="/projects" element={<ProjectsPage />} />
          <Route path="/skills" element={<SkillsPage />} />
          <Route path="/contact" element={<ContactPage />} />
          <Route path="*" element={<NotFoundPage />} />
        </Routes>
      </main>
      {showFooter && <Footer />}
    </>
  )
}
export default App
