import './Eyebrow.css'

type EyebrowProps = {
  label: string
  status?: string
}

function Eyebrow({ label, status }: EyebrowProps) {
  return (
    <div className="eyebrow">
      <p className="label label-accent">{label}</p>
      {status && <p className="label eyebrow-status">{status}</p>}
    </div>
  )
}

export default Eyebrow
