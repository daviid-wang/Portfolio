import { useEffect, useState } from 'react'

import Eyebrow from '../components/Eyebrow'
import CallToAction from '../components/CallToAction'

import type { SkillLevel, SkillGroup } from '../types'

import './SkillsPage.css'

const levelLabel: Record<SkillLevel, string> = {
  production: 'Production',
  project: 'Project',
  learning: 'Learning',
}

function SkillsPage() {
  const [skillGroup, setSkillGroup] = useState<SkillGroup[] | null>(null)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    fetch('/api/skillgroups')
      .then((res) => {
        if (!res.ok) throw new Error(`HTTP ${res.status}`)
        return res.json()
      })
      .then(setSkillGroup)
      .catch((err) => setError(err.message))
  }, [])

  return (
    <section className="container">
      <Eyebrow label="Skills" />
      <header className="skills-summary">
        <h1 className="title">
          Tools I use, and <br />
          where I've used them.
        </h1>
        <p className="skills-text">
          Every skill here is tied to real work: this site, built with React,
          TypeScript and .NET, production features at a charter airline, and
          client projects at university.
        </p>
        <ul className="skills-level">
          {Object.entries(levelLabel).map(([key, label]) => (
            <li key={key}>
              <span
                className={`skills-level-swatch skills-level-swatch-${key}`}
                aria-hidden="true"
              />
              Used in {label.toLowerCase()}
            </li>
          ))}
        </ul>
      </header>

      {error && <p>Error: {error}</p>}
      {!error && skillGroup === null && <p>Loading skills...</p>}
      {skillGroup?.map((g, i) => (
        <section
          key={g.title}
          className="skills-group"
          aria-labelledby={`skills-group-${i}`}
        >
          <div className="skills-group-intro">
            <p className="label label-muted">
              {String(i + 1).padStart(2, '0')}
            </p>
            <h2 id={`skills-group-${i}`} className="skills-group-title">
              {g.title}
            </h2>
            <p className="skills-group-summary">{g.summary}</p>
          </div>
          <ul className="skills-grid">
            {g.skills.map((s) => (
              <li key={s.name} className={`skill-card skill-card-${s.level}`}>
                <p className="label label-muted">{levelLabel[s.level]}</p>
                <p className="label label-accent">
                  {s.source.map((src) => (
                    <li key={src} className="label">
                      {src.replaceAll('-', ' ')}
                    </li>
                  ))}
                </p>
                <h3 className="skill-card-title">{s.name}</h3>
                <p className="skill-card-description">{s.description}</p>
              </li>
            ))}
          </ul>
        </section>
      ))}
      <CallToAction />
    </section>
  )
}

export default SkillsPage
