import { useEffect, useState } from 'react'

import Eyebrow from '../components/Eyebrow'
import type { Education } from '../types'
import EducationCard from '../components/EducationCard'

import './EducationPage.css'

const facts = [
  { term: 'Degree', value: 'BSc (Software Engineering)' },
  { term: 'University', value: 'University of Western Australia' },
  { term: 'Scholarship', value: 'UWA Engineering Scholarship' },
  { term: 'Client projects', value: '2 during the degree' },
]

function EducationPage() {
  const [education, setEducation] = useState<Education[] | null>(null)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    fetch('/api/education')
      .then((res) => {
        if (!res.ok) throw new Error(`HTTP ${res.status}`)
        return res.json()
      })
      .then(setEducation)
      .catch((err) => setError(err.message))
  }, [])

  return (
    <section className="container">
      <Eyebrow label="Education" />
      <header>
        <h1 className="title">
          Engineering degree. <br />
          Solid Fundamentals.
        </h1>
        <p className="heading-text">
          I studied Software Engineering at the University of Western Australia,
          graduating in 2023. Then a year of post graduate study before moving
          into freelance development. My strongest learning at university came
          from projects with real users: a plagiarism checker for UWA academics
          and websites for not-for-profits through Coders for Causes.
        </p>
      </header>
      <div className="education-facts-strip">
        <dl className="education-facts">
          {facts.map((f) => (
            <div key={f.term}>
              <dt className="label label-accent">{f.term}</dt>
              <dd>{f.value}</dd>
            </div>
          ))}
        </dl>
      </div>
      {error && <p>Error: {error}</p>}
      {!error && education === null && <p>Loading education...</p>}
      {education?.map((e) => (
        <EducationCard key={e.id} education={e} />
      ))}
    </section>
  )
}

export default EducationPage
