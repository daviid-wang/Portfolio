export type Experience = {
  id: number
  role: string
  description: string[]
  tech: string[]
  dateFrom: string
  dateTo: string | null
  company: string
  location: string
}

export type ProjectLink = {
  label: string
  url: string
}

export type Project = {
  id: number
  title: string
  eyebrow: string
  description: string
  tech: string[]
  links: ProjectLink[]
}

export type SkillLevel = 'production' | 'project' | 'learning'

export type Source =
  'this-site' | 'coders-for-causes' | 'airline' | 'capstone-project'

export type Skill = {
  name: string
  source: Source[]
  level: SkillLevel
  description: string
}

export type SkillGroup = {
  title: string
  summary: string
  skills: Skill[]
}

export type Scholarship = {
  title: string
  description: string
}

export type EducationHighlight = {
  eyebrow: string
  title: string
  description: string
  tech: string[]
}

export type Education = {
  id: number
  degree: string
  university: string
  location: string
  dateFrom: string
  dateTo: string
  status: string
  summary: string | null
  scholarship: Scholarship | null
  highlights: EducationHighlight[]
  units: string[]
}
