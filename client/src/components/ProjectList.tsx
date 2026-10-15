import type { Project } from "../types";
import ProjectCard from "./ProjectCard";

type ProjectListProps = {
  projects: Project[];
};

function ProjectList({ projects }: ProjectListProps) {
  if (projects.length === 0) return <p>No projects yet.</p>;

  return (
    <ul>
      {projects.map((p) => (
        <ProjectCard key={p.id} project={p} />
      ))}
    </ul>
  );
}

export default ProjectList;
