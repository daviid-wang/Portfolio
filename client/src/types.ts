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
  slug: string
  title: string
  eyebrow: string
  description: string
  tech: string[]
  links: ProjectLink[]
}

export type SkillLevel = 'production' | 'project' | 'learning'

export type Source = 'this-site' | 'coders-for-causes' | 'airline' | 'capstone-project'

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