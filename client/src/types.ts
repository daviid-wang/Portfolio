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
