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

export type Project = {
  id: number
  title: string
  description: string
  tech: string[]
}