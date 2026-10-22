import type { Experience } from '../types'
import ExperienceCard from './ExperienceCard'

type ExperienceListProps = {
  experiences: Experience[]
}

function ExperienceList({ experiences }: ExperienceListProps) {
  if (experiences.length === 0) return <p>No experiences yet.</p>

  return (
    <ul>
      {experiences.map((e) => (
        <ExperienceCard key={e.id} experience={e} />
      ))}
    </ul>
  )
}

export default ExperienceList
