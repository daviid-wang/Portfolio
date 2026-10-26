import { useEffect, useState } from 'react'

import Eyebrow from '../components/Eyebrow'

import './EducationPage.css'

function EducationPage() {
  return (
    <section className="container">
      <Eyebrow label="Education" />
      <header>
        <h1 className="title">
          Engineering degree. <br />
          Solid Fundamentals.
        </h1>
        <p className='heading-text'>
          I studied Software Engineering at the University of Western Australia,
          graduating in 2023. Then a year of post graduate study before moving
          into freelance development. My strongest learning at university came
          from projects with real users: a plagiarism checker for UWA academics
          and websites for not-for-profits through Coders for Causes.
        </p>
      </header>
    </section>
  )
}

export default EducationPage
